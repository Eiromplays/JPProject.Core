using Bogus;
using JPProject.Admin.Domain.Commands.Clients;

namespace JPProject.Admin.Fakers.Test.ClientFakers
{
    public class ClientCommandFaker
    {
        public static Faker<SaveClientCommand> GenerateSaveClientCommand(string postLogoutUri = null, string clientId = null)
        {
            return new Faker<SaveClientCommand>().CustomInstantiator(f =>
                new SaveClientCommand(
                    clientId ?? f.Lorem.Word(),
                    f.Company.CompanyName(),
                    f.Internet.Url(),
                    f.Image.LoremFlickrUrl(),
                    f.Lorem.Sentence(),
                    f.PickRandom<ClientType>(),
                    postLogoutUri ?? f.Internet.Url()
                ));

        }
        public static Faker<CopyClientCommand> GenerateCopyClientCommand()
        {
            return new Faker<CopyClientCommand>().CustomInstantiator(f =>
                new CopyClientCommand(f.Lorem.Word()));
        }

        public static Faker<UpdateClientCommand> GenerateUpdateClientCommand(
            int? absoluteRefreshTokenLifetime = null,
            int? identityTokenLifetime = null,
            int? accessTokenLifetime = null,
            int? authorizationCodeLifetime = null,
            int? slidingRefreshTokenLifetime = null,
            int? deviceCodeLifetime = null,
            string oldClientId = null)
        {
            return new Faker<UpdateClientCommand>().CustomInstantiator(f =>
                new UpdateClientCommand(
                    ClientFaker.GenerateClient(absoluteRefreshTokenLifetime,
                        identityTokenLifetime,
                        accessTokenLifetime,
                        authorizationCodeLifetime,
                        slidingRefreshTokenLifetime,
                        deviceCodeLifetime).Generate(),
                    oldClientId ?? f.System.AndroidId()
                    ));


        }

        public static Faker<RemoveClientCommand> GenerateRemoveClientCommand()
        {
            return new Faker<RemoveClientCommand>().CustomInstantiator(f => new RemoveClientCommand(f.Lorem.Word()));
        }

        public static Faker<RemoveClientSecretCommand> GenerateRemoveClientSecretCommand(string type = null, string value = null)
        {
            return new Faker<RemoveClientSecretCommand>().CustomInstantiator(f => new RemoveClientSecretCommand(
                type ?? f.Random.Word(),
                value ?? f.Lorem.Sentence(),
                f.Internet.DomainName()));
        }

        public static Faker<SaveClientSecretCommand> GenerateSaveClientSecretCommand()
        {
            return new Faker<SaveClientSecretCommand>().CustomInstantiator(f => new SaveClientSecretCommand(
                f.Lorem.Word(),
                f.Lorem.Sentence(),
                f.Lorem.Word(),
                f.Lorem.Word(),
                f.Date.Future(),
                f.Random.Int(0, 1)
                ));
        }

        public static Faker<RemovePropertyCommand> GenerateRemovePropertyCommand(string key = null)
        {
            return new Faker<RemovePropertyCommand>().CustomInstantiator(f => new RemovePropertyCommand(
                key ?? f.Random.Word(),
                f.Random.Word(),
                f.Internet.DomainName()
            ));
        }

        public static Faker<SaveClientPropertyCommand> GenerateSavePropertyCommand()
        {
            return new Faker<SaveClientPropertyCommand>().CustomInstantiator(f => new SaveClientPropertyCommand(
                f.Random.Word(),
                f.Random.Word(),
                f.Random.Word()
            ));
        }

        public static Faker<RemoveClientClaimCommand> GenerateRemoveClaimCommand(string type = null, string value = null)
        {
            return new Faker<RemoveClientClaimCommand>().CustomInstantiator(f => new RemoveClientClaimCommand(
                type ?? f.Random.Word(),
                value ?? f.Random.Words(),
                f.Internet.DomainName()
            ));
        }
        public static Faker<SaveClientClaimCommand> GenerateSaveClaimCommand()
        {
            return new Faker<SaveClientClaimCommand>().CustomInstantiator(f => new SaveClientClaimCommand(
                f.Random.Word(),
                f.Random.Word(),
                f.Random.Word()
            ));
        }

    }
}
