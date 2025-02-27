﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace KAF.AppConfiguration.EncryptionHandler
{
    public class DecryptTransformer
    {
        EncryptionAlgorithm algorithmID;
        string SecurityKey = "";
        Byte[] IV;
        bool bHasIV = false;

        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   User, 2/1/2017. </remarks>
        ///
        /// <param name="algID">    Identifier for the algorithm. </param>

        public DecryptTransformer(EncryptionAlgorithm algID)
        {
            algorithmID = algID;
        }

        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   User, 2/1/2017. </remarks>
        ///
        /// <param name="algID">    Identifier for the algorithm. </param>
        /// <param name="iv">       The iv. </param>

        public DecryptTransformer(EncryptionAlgorithm algID, byte[] iv)
        {
            algorithmID = algID;
            IV = iv;
            bHasIV = true;
        }

        /// <summary>   Gets or sets the encryption algorithm. </summary>
        ///
        /// <value> The encryption algorithm. </value>

        public EncryptionAlgorithm EncryptionAlgorithm
        {
            get
            {
                return algorithmID;
            }
            set
            {
                algorithmID = value;
            }
        }

        /// <summary>   Sets security key. </summary>
        ///
        /// <remarks>   User, 2/1/2017. </remarks>
        ///
        /// <param name="Key">  The key. </param>

        public void SetSecurityKey(string Key)
        {
            SecurityKey = Key;
        }

        /// <summary>   Gets crypto transform. </summary>
        ///
        /// <remarks>   User, 2/1/2017. </remarks>
        ///
        /// <exception cref="CryptographicException">   Thrown when a Cryptographic error condition
        ///                                             occurs. </exception>
        ///
        /// <returns>   The crypto transform. </returns>

        public ICryptoTransform GetCryptoTransform()
        {
            bool bHasSecuityKey = false;
            if (SecurityKey.Length != 0)
                bHasSecuityKey = true;

            byte[] key = Encoding.ASCII.GetBytes(SecurityKey);
            switch (algorithmID)
            {
                case EncryptionAlgorithm.DES:
                    DES des = new DESCryptoServiceProvider();
                    if (bHasSecuityKey) des.Key = key;
                    if (bHasIV) des.IV = IV;
                    return des.CreateDecryptor();

                case EncryptionAlgorithm.Rc2:
                    RC2 rc = new RC2CryptoServiceProvider();
                    if (bHasSecuityKey) rc.Key = key;
                    if (bHasIV) rc.IV = IV;
                    return rc.CreateDecryptor();
                case EncryptionAlgorithm.Rijndael:
                    Rijndael rj = new RijndaelManaged();
                    if (bHasSecuityKey) rj.Key = key;
                    if (bHasIV) rj.IV = IV; ;
                    return rj.CreateDecryptor();
                case EncryptionAlgorithm.TripleDes:
                    TripleDES tDes = new TripleDESCryptoServiceProvider();
                    if (bHasSecuityKey) tDes.Key = key;
                    if (bHasIV) tDes.IV = IV;
                    return tDes.CreateDecryptor();
                default:
                    throw new CryptographicException("Algorithm ID '" + algorithmID + "' not supported.");
            }
        }
    }
    public class Decryptor
    {
        EncryptionAlgorithm AlgoritmID;
        byte[] IV;

        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   User, 2/1/2017. </remarks>
        ///
        /// <param name="algID">    Identifier for the algorithm. </param>

        public Decryptor(EncryptionAlgorithm algID)
        {
            AlgoritmID = algID;
        }

        /// <summary>   Constructor. </summary>
        /// <remarks>   2/1/2017. </remarks>
        /// <param name="algID">    Identifier for the algorithm. </param>
        /// <param name="iv">       The iv. </param>

        public Decryptor(EncryptionAlgorithm algID, byte[] iv)
        {
            AlgoritmID = algID;
            IV = iv;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the decrypt transformer. </summary>
        /// <value> The decrypt transformer. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public DecryptTransformer DecryptTransformer
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Decrypts. </summary>
        /// <param name="MainString">   The main string. </param>
        /// <param name="key">          The key. </param>
        /// <returns>   A string. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string Decrypt(string MainString, string key)
        {
            DecryptTransformer dt = new DecryptTransformer(AlgoritmID, IV);
            dt.SetSecurityKey(key);

            byte[] buffer = Convert.FromBase64String(MainString.Trim());
            MemoryStream ms = new MemoryStream(buffer);

            // Create a CryptoStream using the memory stream and the 
            // CSP DES key. 
            CryptoStream encStream = new CryptoStream(ms, dt.GetCryptoTransform(), CryptoStreamMode.Read);

            // Create a StreamReader for reading the stream.
            StreamReader sr = new StreamReader(encStream);

            // Read the stream as a string.
            string val = sr.ReadLine();

            // Close the streams.
            sr.Close();
            encStream.Close();
            ms.Close();

            return val;


        }
    }
}
