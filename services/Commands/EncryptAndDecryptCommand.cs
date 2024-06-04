using Encryption_and_decryption_csharp.Models;
using EncryptionDecryptionUsingSymmetricKey;
using MediatR;

namespace Encryption_and_decryption_csharp.services.Commands;
#nullable disable 
public class EncryptAndDecryptCommand : IRequest<EncryptAndDecryptResult>
{
    public string Text { get; set; }

    public EncryptAndDecryptCommand(string Text)
    {
        this.Text = Text;
    }
}

public class EncryptAndDecryptResult
{
    public string EncryptText { get; set; }
    public string DescryptText { get; set; }
}

public class EncryptAndDecryptCommandHandler : IRequestHandler<EncryptAndDecryptCommand, EncryptAndDecryptResult>
{
    public async Task<EncryptAndDecryptResult> Handle(EncryptAndDecryptCommand request, CancellationToken cancellationToken)
    {

        var textFromEncript = request.Text;
        var result = AesOperation.EncryptString(textFromEncript);
        var dataDescript = AesOperation.DecryptString(result);
        return new EncryptAndDecryptResult
        {
            EncryptText = result,
            DescryptText = dataDescript
        };
    }
}