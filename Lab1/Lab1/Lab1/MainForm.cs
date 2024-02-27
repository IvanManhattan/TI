using System;
using System.Windows.Forms;

namespace Lab1 {
    
    public partial class MainForm : Form {

        private char[,] _encryptTable = {
            {'C', 'R', 'Y', 'P', 'T'},
            {'O', 'G', 'A', 'H', 'B'},
            {'D', 'E', 'F', 'I', 'K'},
            {'L', 'M', 'N', 'Q', 'S'},
            {'U', 'V', 'W', 'X', 'Z'}
        };

        public static char VoidSymbol = 'X';
        
        private string _textToEncrypt; 
        
        public MainForm() {
            InitializeComponent();
        }

        private char[] prepareTextPleifer() {
            
            for (int i = 0; i < _textToEncrypt.Length - 1; i++) {
                if (_textToEncrypt[i] == _textToEncrypt[i + 1]) {
                    _textToEncrypt.Insert(i + 1, new string(VoidSymbol, 1));
                }
            }

            if ((_textToEncrypt.Length & 1) != 0) {
                _textToEncrypt += VoidSymbol;
            }

            var textToEncryptArray = new char[_textToEncrypt.Length];
            
            for (int j = 0; j < _textToEncrypt.Length; j++) {
                textToEncryptArray[j] = _textToEncrypt[j];
            }

            return textToEncryptArray;

        }
        
        private string EncryptText() {
            _textToEncrypt = textBox1.Text;
            
            int j = 0;
            int action = 0;
            int[,] indexes = new int[2,2];
            char[] symbols = new char[2];
            int k = 0;
            
            var textToEncryptArray = prepareTextPleifer();
            var encryptedText = new char[textToEncryptArray.Length];
            
            for (int i = 0; i < textToEncryptArray.Length; i += 2) {
                symbols[k] = _textToEncrypt[i];
                symbols[k + 1] = _textToEncrypt[i + 1];

                indexes = GetIndex(symbols);
                action = CheckTable(indexes);

                if (action == 1) {
                    if (indexes[0, 1] + 1 >= _encryptTable.GetLength(0)) {
                        encryptedText[i] = _encryptTable[indexes[0, 0], 0];
                        encryptedText[i + 1] = _encryptTable[indexes[1, 0], indexes[1, 1] + 1];
                    }
                    else if (indexes[1, 1] + 1 >= _encryptTable.GetLength(0)) {
                        encryptedText[i] = _encryptTable[indexes[0, 0], indexes[0, 1] + 1];
                        encryptedText[i + 1] = _encryptTable[indexes[1, 0], 0];
                    }
                    else {
                        encryptedText[i] = _encryptTable[indexes[0, 0], indexes[0, 1] + 1];
                        encryptedText[i + 1] = _encryptTable[indexes[1, 0], indexes[1, 1] + 1];
                    }
                }

                if (action == 2) {
                    if (indexes[0, 0] + 1 >= _encryptTable.GetLength(0)) {
                        encryptedText[i] = _encryptTable[0, indexes[0, 1]];
                        encryptedText[i + 1] = _encryptTable[indexes[1, 0] + 1, indexes[1, 1]];
                    }
                    else if (indexes[1, 0] + 1 >= _encryptTable.GetLength(0)) {
                        encryptedText[i] = _encryptTable[indexes[0, 0] + 1, indexes[0, 1]];
                        encryptedText[i + 1] = _encryptTable[0, indexes[1, 1]];
                    }
                    else {
                        encryptedText[i] = _encryptTable[indexes[0, 0] + 1, indexes[0, 1]];
                        encryptedText[i + 1] = _encryptTable[indexes[1, 0] + 1, indexes[1, 1]];
                    }
                }

                if (action == 3) {
                    int delta = Math.Abs(indexes[0, 1] - indexes[1, 1]);
                    if (indexes[0, 1] < indexes[1, 1]) {
                        encryptedText[i] = _encryptTable[indexes[0, 0], indexes[0, 1] + delta];
                        encryptedText[i + 1] = _encryptTable[indexes[1, 0], indexes[1, 1] - delta];
                    }
                    else {
                        encryptedText[i] = _encryptTable[indexes[0, 0], indexes[0, 1] - delta];
                        encryptedText[i + 1] = _encryptTable[indexes[1, 0], indexes[1, 1] + delta];
                    }
                }

                if (action == 4) {
                    continue;
                }
            }

            return new string(encryptedText);
        }

        private int[,] GetIndex(char[] symbols) {
            int[,] indexes = new int[2,2];
            bool isFound = false;
            
            for (int k = 0; k < 2; k++) {
                for (int i = 0; i < _encryptTable.GetLength(0); i++) {
                    for (int j = 0; j < _encryptTable.GetLength(0); j++) {
                        if (symbols[k] == _encryptTable[i, j]) {
                            isFound = true;
                            indexes[k, 0] = i;
                            indexes[k, 1] = j;
                            break;
                        }
                    }
                    if (isFound) {
                        isFound = false;
                        break;
                    }
                }
            }

            return indexes;
        }

        private int CheckTable(int[,] indexes) {

            if (indexes[0, 0] == indexes[1, 0]) {
                return 1;
            }
            if (indexes[0, 1] == indexes[1, 1]) {
                return 2;
            }

            if (indexes[0, 0] != indexes[1, 0] && indexes[0, 1] != indexes[1, 1]) {
                return 3;
            }
            
            if (indexes[0, 0] == indexes[1, 0] && indexes[0, 1] == indexes[1, 1]) {
                return 4;
            }

            return 0;
        }

        private void button1_Click(object sender, EventArgs e) {
            textBox2.Text = EncryptText();
        }
    }
}