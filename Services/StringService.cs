using System;

namespace StringProcessingApp.Services
{
    public class StringService
    {
        private string _originalText = "";
        private string _currentText = "";

        public void SetText(string text)
        {
            _originalText = text;
            _currentText = text;
        }

        public string GetText()
        {
            return _currentText;
        }

        public void ToUpperCase()
        {
            _currentText = _currentText.ToUpper();
        }

        public void ToLowerCase()
        {
            _currentText = _currentText.ToLower();
        }

        public int CountCharacters()
        {
            return _currentText.Length;
        }

        public bool ContainsWord(string word)
        {
            return _currentText.Contains(word);
        }

        public void ReplaceWord(string oldWord, string newWord)
        {
            _currentText = _currentText.Replace(oldWord, newWord);
        }

        public string ExtractSubstring(int startIndex, int length)
        {
            return _currentText.Substring(startIndex, length);
        }

        public void TrimSpaces()
        {
            _currentText = _currentText.Trim();
        }

        public void Reset()
        {
            _currentText = _originalText;
        }
    }
}
