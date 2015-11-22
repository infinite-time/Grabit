
namespace Grabit
{
    /// <summary>
    /// Classes which implement writing calculated data must implement this interface. 
    /// This enables easier extensibility. For ex: we can read either write to console or Db or file by implementing
    /// appropriate classes inherting from this interface.
    public interface IWriter{
        void Write();
    }
}
