using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grabit
{
    public enum ReaderType {
        CONSOLE_READER
    }

    public enum WriterType {
        CONSOLE_WRITER
    }

    public class ReaderWriterFactory {
        private static ReaderWriterFactory readWriteFactory;

        public static ReaderWriterFactory GetInstance() {
            if(readWriteFactory == null) {
                readWriteFactory = new ReaderWriterFactory();
            }
            return readWriteFactory;
        }

        private ReaderWriterFactory() {}

        public IReader GetReader(ReaderType type) {
            IReader reader = null;
            switch(type) {
                case ReaderType.CONSOLE_READER:
                    reader = new ConsoleReader();
                    break;
            }
            return reader;
        }

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
