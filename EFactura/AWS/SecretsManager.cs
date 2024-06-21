using Amazon.SecretsManager;
using Amazon.SecretsManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFactura.AWS
{
    public class SecretsManager
    {
        private readonly IAmazonSecretsManager _secretsManager; 
        public SecretsManager(IAmazonSecretsManager secretsManager)
        {
            _secretsManager = secretsManager;
        }
        public async Task<string> GetSecretAsync(string secretName)
        {
            GetSecretValueRequest request = new GetSecretValueRequest
            {
                SecretId = secretName
            };
            GetSecretValueResponse response = await _secretsManager.GetSecretValueAsync(request);
            if (response == null)
            {
                return null;
            }
            return response.SecretString;
        }
    }
}
