using Encryption;
Methods method = new Methods();

Console.Write("Type password: ");
string password = Console.ReadLine();
string encrypted_password = new string(method.Encrypt(password));
string decrypted_password = new string(method.Decrypt(encrypted_password));

Console.WriteLine($"Encrypted password: {encrypted_password}");
Console.WriteLine($"Decrypted password: {decrypted_password}");



