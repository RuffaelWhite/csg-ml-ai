using System;
using System.Security.Cryptography;
using System.Text;
using UnityEngine;

/// <summary>
/// Provides basic end-to-end encryption functionality using AES.
/// This class can be used to encrypt and decrypt data transmissions.
/// </summary>
public class EndToEndEncryption : MonoBehaviour
{
    private Aes aes;

    void Awake()
    {
        aes = Aes.Create();
        aes.KeySize = 256;
        aes.BlockSize = 128;
        aes.Mode = CipherMode.CBC;
        aes.Padding = PaddingMode.PKCS7;
        aes.GenerateKey();
        aes.GenerateIV();
        Debug.Log("AES encryption initialized.");
    }

    public byte[] Encrypt(string plainText)
    {
        byte[] encrypted;
        ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
        using (var ms = new System.IO.MemoryStream())
        {
            using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
            using (var sw = new System.IO.StreamWriter(cs))
            {
                sw.Write(plainText);
            }
            encrypted = ms.ToArray();
        }
        return encrypted;
    }

    public string Decrypt(byte[] cipherText)
    {
        string plaintext = null;
        ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
        using (var ms = new System.IO.MemoryStream(cipherText))
        {
            using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
            using (var sr = new System.IO.StreamReader(cs))
            {
                plaintext = sr.ReadToEnd();
            }
        }
        return plaintext;
    }

    public byte[] GetKey()
    {
        return aes.Key;
    }

    public byte[] GetIV()
    {
        return aes.IV;
    }
}
