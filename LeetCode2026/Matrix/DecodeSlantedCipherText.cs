namespace LeetCode2026.Matrix;

using System.Text;

// 2075. Decode the Slanted Ciphertext
// A string originalText is encoded using a slanted transposition cipher 
// to a string encodedText with the help of a matrix having a fixed number of rows rows.
// originalText is placed first in a top-left to bottom-right manner.
// Given the encoded string encodedText and number of rows rows, return the original string originalText.

public class DecodeSlantedCipherText 
{
    public string DecodeCiphertext(string encodedText, int rows) 
    {
        if (string.IsNullOrEmpty(encodedText) || rows == 0)
        {
            return string.Empty;
        }

        int columns = encodedText.Length / rows;
        var matrix = new char[rows, columns];
        
        for (int i = 0; i < encodedText.Length; i++)
        {
            int row = i / columns;
            int column = i % columns;
            matrix[row, column] = encodedText[i];
        }

        var originalText = new StringBuilder(encodedText.Length);

        for (int i = 0; i < columns; i++)
        {
            int row = 0;
            int column = i;

            while (row < rows && column < columns)
            {
                originalText.Append(matrix[row, column]);
                row++;
                column++;
            }
        }
        
        return originalText.ToString().TrimEnd();
    }
}