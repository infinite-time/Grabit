
namespace Grabit
{
    /// <summary>
    /// Enum specifying the type of reader. This can be extended to include multiple type of readers in future. Ex: DB, file
    /// </summary>
    public enum ReaderType {
        CONSOLE_READER
    }

    /// <summary>
    /// Enum specifying the type of writer. This can be extended to include multiple type of writer in future. Ex: DB, file
    /// </summary>
    public enum WriterType {
        CONSOLE_WRITER
    }

    /// <summary>
    /// This class provides factory implementation to give the type of reader/writer requested.
    /// </summary>
    public class ReaderWriterFactory {

        /// <summary>
        /// Singleton instance
        /// </summary>
        private static ReaderWriterFactory readWriteFactory;

        /// <summary>
        /// Static method which creates an instance of the class if not created
        /// </summary>
        /// <returns>ReaderWriterFactory</returns>
        public static ReaderWriterFactory GetInstance() {
            if(readWriteFactory == null) {
                readWriteFactory = new ReaderWriterFactory();
            }
            return readWriteFactory;
        }

        /// <summary>
        /// Private constructor to help in singleton implementation
        /// </summary>
        private ReaderWriterFactory() {}

        /// <summary>
        /// Returns the type of reader requested
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public IReader GetReader(ReaderType type) {
            IReader reader = null;
            switch(type) {
                case ReaderType.CONSOLE_READER:
                    reader = new ConsoleReader();
                    break;
            }
            return reader;
        }

        /// <summary>
        /// Returns the type of writer requested
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public IWriter GetWriter(WriterType type)
        {
            IWriter writer = null;
            switch (type) {
                case WriterType.CONSOLE_WRITER:
                    writer = new ConsoleWriter();
                    break;
            }
            return writer;
        }
    }
}
