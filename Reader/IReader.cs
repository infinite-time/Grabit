
namespace Grabit
{
    /// <summary>
    /// Classes which implement reading input data must implement this interface. 
    /// This enables easier extensibility. For ex: we can read either read from console or Db or file by implementing
    /// appropriate classes inherting from this interface.
    /// </summary>
    public interface IReader {
        void ReadAndStore();
    }
}
