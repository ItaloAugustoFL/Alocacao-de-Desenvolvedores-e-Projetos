using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AlocacaoDesenvolvedorTrabalho
{
    [Table("credencial")]
    public class Credencial
    {
        public Int64 Id { get; set; }
        public const String Salt = "ratatosrk_pelundingo:";

        [Index(IsUnique = true)]
        [StringLength(250)]
        [Required]
        public String Email { get; set; }
        
        private String _senha;

        [Required]
        [StringLength(64)]

        //senha criptografando duas vezes
        public String Senha
        {

            get
            {
                return _senha;
            }

            set
            {
                if (value.Length == 64)
                {
                    _senha = value;
                }
                else if (value.Length >= 8 && value.Length <= 12)
                {
                    _senha = ComputeSHA256(value, Salt);
                }
                else
                {
                    throw new ArgumentException("Calma! Senha muito grande ou pequena demais!\"\nO Ratatoskr garante sua segurança, fica de boa!");
                }
            }
        }
        public Boolean Ativo { get; set; }
        public Boolean Adiministrador { get; set; }

        public Credencial()
        {
        }
        public Credencial(String email, String senha, bool ativo, bool adm)
        {
            Email = email;
            Senha = senha;
            Ativo = ativo;
            Adiministrador = adm;
        }

        [Required]
        public Desenvolvedor Desenvolvedor { get; set; }

        //Parte do hashing q é receita de bolo, faz a criptografia e talz
        #region Hashing
        public static String ComputeSHA256(String input)
        {
            return ComputeSHA256(input, null);
        }

        public static String ComputeSHA256(String input, String salt)
        {
            String hash = String.Empty;

            // 
            // https://learn.microsoft.com/en-us/dotnet/standard/security/cryptographic-services
            // https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.sha256?view=netframework-4.8
            // https://www.techiedelight.com/generate-sha-256-hash-of-string-csharp/
            // 

            // Initialize a SHA256 hash object
            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute the hash of the given string
                byte[] hashValue = sha256.ComputeHash(
                    Encoding.UTF8.GetBytes(salt + input));

                // Convert the byte array to string format
                foreach (byte b in hashValue)
                {
                    hash += $"{b:X2}";
                }
            }

            return hash;
        }
        #endregion
    }
}
