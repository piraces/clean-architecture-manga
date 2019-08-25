namespace Manga.Application.Boundaries.Transfer
{
    public interface IOutputHandler : IErrorHandler
    {
        void Handle(TransferOutput output);
    }
}