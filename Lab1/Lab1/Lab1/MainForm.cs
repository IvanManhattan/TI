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

        private char[,] _vigenereTable = {
            { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я', }, 
            { 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я', 'А', }, 
            { 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я', 'А', 'Б', }, 
            { 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я', 'А', 'Б', 'В', }, 
            { 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я', 'А', 'Б', 'В', 'Г', }, 
            { 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я', 'А', 'Б', 'В', 'Г', 'Д', }, 
            { 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я', 'А', 'Б', 'В', 'Г', 'Д', 'Е', }, 
            { 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', }, 
            { 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', }, 
            { 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', }, 
            { 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', }, 
            { 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', }, 
            { 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', }, 
            { 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', }, 
            { 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', }, 
            { 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', }, 
            { 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', }, 
            { 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', }, 
            { 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', }, 
            { 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', }, 
            { 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', }, 
            { 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', }, 
            { 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', }, 
            { 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', }, 
            { 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', }, 
            { 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', }, 
            { 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', }, 
            { 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', }, 
            { 'Ы', 'Ъ', 'Э', 'Ю', 'Я', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', }, 
            { 'Ъ', 'Э', 'Ю', 'Я', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', }, 
            { 'Э', 'Ю', 'Я', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', }, 
            { 'Ю', 'Я', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', }, 
            { 'Я', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', }, 
        };

        public static char VoidSymbol = 'X';
        
        private string _textToEncryptPleifer;
        
        private string _textToEncryptVigenere;
        
        public MainForm() {
            InitializeComponent();
        }
        
        private char[] PrepareTextPleifer() {

            int tempLen = 0;
            _textToEncryptPleifer = _textToEncryptPleifer.ToUpper();
            
            for (int i = 0; i < _textToEncryptPleifer.Length - 1; i++) {
                if (_textToEncryptPleifer[i] != ' ') {
                    if (_textToEncryptPleifer[i] == _textToEncryptPleifer[i + 1]) {
                        _textToEncryptPleifer.Insert(i + 1, new string(VoidSymbol, 1));
                    }
                }
            }
            
            for (int i = 0; i < _textToEncryptPleifer.Length; i++) {
                if (_textToEncryptPleifer[i] != ' ') {
                    tempLen++;
                }
            }
            
            if ((tempLen & 1) != 0) {
                _textToEncryptPleifer += VoidSymbol;
                tempLen++;
            }
           
            var textToEncryptArray = new char[tempLen];

            int t = 0;
            for (int j = 0; j < _textToEncryptPleifer.Length; j++) {
                if (_textToEncryptPleifer[j] >= 65 && _textToEncryptPleifer[j] <= 90 
                    || _textToEncryptPleifer[j] == ' ') {
                    if (_textToEncryptPleifer[j] != ' ') {
                        textToEncryptArray[t] = _textToEncryptPleifer[j];
                        t++;
                    }
                }
                else {
                    textBoxMessages.Text = "Not english symbol";
                    return null;
                }
            }

            textBoxMessages.Clear();
            return textToEncryptArray;

        }
        
        private string EncryptDecryptTextPleifer(int scenario) {
            /*  
             *  scenario = 1 means encrypt
             *  scenario = -1 means decrypt
             */
            _textToEncryptPleifer = textBox1.Text;
            
            int j = 0;
            int action = 0;
            int[,] indexes = new int[2,2];
            char[] symbols = new char[2];
            int k = 0;
            
            var textToEncryptArray = PrepareTextPleifer();
            if (textToEncryptArray == null) {
                return null;
            }
            var encryptedText = new char[textToEncryptArray.Length];
            
            for (int i = 0; i < textToEncryptArray.Length; i += 2) {
                symbols[k] = textToEncryptArray[i];
                symbols[k + 1] = textToEncryptArray[i + 1];

                indexes = GetIndex(symbols);
                action = CheckTable(indexes);

                if (action == 1) {
                    
                    if (indexes[0, 1] + 1 >= _encryptTable.GetLength(0)
                        || (indexes[0, 1] - 1 < 0 && scenario == -1)) {
                        if (scenario == 1) {
                            encryptedText[i] = _encryptTable[indexes[0, 0], 0];
                        }
                        else {
                            encryptedText[i] = _encryptTable[indexes[0, 0], _encryptTable.GetLength(0) - 1];
                        }
                        encryptedText[i + 1] = _encryptTable[indexes[1, 0], indexes[1, 1] + 1 * scenario];
                    }
                    
                    else if (indexes[1, 1] + 1 >= _encryptTable.GetLength(0)
                             || (indexes[1, 1] - 1 < 0 && scenario == -1)) {
                        encryptedText[i] = _encryptTable[indexes[0, 0], indexes[0, 1] + 1 * scenario];
                        if (scenario == 1) {
                            encryptedText[i + 1] = _encryptTable[indexes[1, 0], 0];                       
                        }
                        else {
                            encryptedText[i + 1] = _encryptTable[indexes[1, 0], _encryptTable.GetLength(0) - 1];
                        }
                    }
                    else {
                        encryptedText[i] = _encryptTable[indexes[0, 0], indexes[0, 1] + 1 * scenario];
                        encryptedText[i + 1] = _encryptTable[indexes[1, 0], indexes[1, 1] + 1 * scenario];
                    }
                }

                if (action == 2) {
                    if (indexes[0, 0] + 1 >= _encryptTable.GetLength(0)
                        || (indexes[0, 0] - 1 < 0 && scenario == -1)) {
                        if (scenario == 1) {
                            encryptedText[i] = _encryptTable[0, indexes[0, 1]];
                        }
                        else {
                            encryptedText[i] = _encryptTable[_encryptTable.GetLength(0) - 1, indexes[0, 1]];
                        }
                        encryptedText[i + 1] = _encryptTable[indexes[1, 0] + 1 * scenario, indexes[1, 1]];
                    }
                    else if (indexes[1, 0] + 1 >= _encryptTable.GetLength(0)
                             || (indexes[1, 0] - 1 < 0 && scenario == -1)) {
                        if (scenario == 1) {
                            encryptedText[i + 1] = _encryptTable[0, indexes[1, 1]];
                        }
                        else {
                            encryptedText[i + 1] = _encryptTable[_encryptTable.GetLength(0) - 1, indexes[1, 1]];
                        }
                        encryptedText[i] = _encryptTable[indexes[0, 0] + 1 * scenario, indexes[0, 1]];
                    }
                    else {
                        encryptedText[i] = _encryptTable[indexes[0, 0] + 1 * scenario, indexes[0, 1]];
                        encryptedText[i + 1] = _encryptTable[indexes[1, 0] + 1 * scenario, indexes[1, 1]];
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
            textBox2.Text = EncryptDecryptTextPleifer(1);
        }

        private void radioButtonVigenere_CheckedChanged(object sender, EventArgs e) {
            if (radioButtonVigenere.Checked) {
                textBoxKeys.ReadOnly = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            if (radioButtonPleifer.Checked) {
                textBoxKeys.Clear();
                textBoxKeys.ReadOnly = true;
            }
        }

        private string EncryptDecryptTextVigenere() {

            // TODO
            
            return null;
        }
    }
}