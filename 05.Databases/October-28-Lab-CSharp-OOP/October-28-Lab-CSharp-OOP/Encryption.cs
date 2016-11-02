using System;

namespace October_28_Lab_CSharp_OOP
{
    public class Encryption
    {
        private string text;

        public Encryption(string textToEncrypt)
        {
            this.Text = textToEncrypt;
            this.Key = textToEncrypt.Length;
        }

        public string Text
        {
            get { return this.text; }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Text cannot be null");
                }

                this.text = value;
            }
        }

        public int Key { get; set; }

        public string Encrypt(string textToEncrypt)
        {
            int rows = (textToEncrypt.Length + 1) / Key;
            int cols = Key;

            char[,] result = new char[rows, cols];
            char[] text = textToEncrypt.ToCharArray();
            char[] encodedChars = new char[text.Length];

            int counter = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (counter < text.Length)
                    {
                        result[i, j] = text[counter++];
                    }
                    else
                    {
                        result[i, j] = ' ';
                    }
                }
            }

            counter = 0;
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    encodedChars[counter++] = result[j, i];
                }
            }

            return new string(encodedChars);

        }

        public string Decrypt(string textToDecrypt)
        {
            int rows = (textToDecrypt.Length + 1) / Key;
            int cols = Key;

            char[,] result = new char[rows, cols];
            char[] text = textToDecrypt.ToCharArray();
            char[] decodedChars = new char[text.Length];

            int counter = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (counter < text.Length)
                    {
                        result[i, j] = text[counter++];
                    }
                    else
                    {
                        result[i, j] = ' ';
                    }
                }
            }

            counter = 0;

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    decodedChars[counter++] = result[j, i];
                }
            }
     
            return new string(decodedChars);
        }
    }
}
