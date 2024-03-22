using System.Security.Cryptography;

// Create a new instance of RSACryptoServiceProvider.
RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

// This is where you'd have your XML string with the RSA key values.
string xmlString = "<RSAKeyValue><Modulus>...</Modulus><Exponent>...</Exponent><P>...</P><Q>...</Q><DP>...</DP><DQ>...</DQ><InverseQ>...</InverseQ><D>...</D></RSAKeyValue>";

// Import the RSA Key information.
rsa.FromXmlString(xmlString);

// Now the RSA object has the key information and can be used for encryption or decryption.
