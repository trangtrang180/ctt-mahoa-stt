using System;

class Program
{
    static void Main()
    {
        string P = "NGUYEN TRAN MINH TRANG"; 
        string C = "";
        int k = 39; // STT của bạn trong danh sách

        for (int i = 0; i < P.Length; i++)
        {
            char ch = P[i];
            if (ch >= 'A' && ch <= 'Z')
            {
                int pos = ch - 'A';
                int newPos = (pos + k) % 26; 
                char newCh = (char)(newPos + 'A');
                C += newCh;
            }
            else
            {
                C += ch; 
            }
        }

        Console.WriteLine("Plaintext: " + P);
        Console.WriteLine("Ciphertext: " + C);
    }
}
