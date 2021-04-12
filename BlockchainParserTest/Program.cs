using System;
using BitcoinBlockchain.Data;
using OrderedBitcoinBlockchainParser;

namespace BlockchainParserTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ////I.初次启动
            //OrderedBitcoinBlockchainParser_Class orderedBlockchainParser1 = new OrderedBitcoinBlockchainParser_Class(@"F:\data\blocks", @"F:\blockProcessContextFile", null);
            //ParserBlock readyBlock1 = orderedBlockchainParser1.getNextBlock();
            //if (readyBlock1 != null)
            //{
            //    Console.WriteLine("Success!!!");
            //    Console.WriteLine(readyBlock1.Header.BlockTime);
            //}
            //else
            //{
            //    Console.WriteLine("Failed!!!");
            //}

            ////II.增量启动
            //OrderedBitcoinBlockchainParser_Class orderedBlockchainParser2 = new OrderedBitcoinBlockchainParser_Class(@"F:\data\blocks", @"F:\blockProcessContextFile", "BPC_154007_2011年11月19日23时24分16秒.dat.rar");
            //ParserBlock readyBlock2 = orderedBlockchainParser2.getNextBlock();
            //if (readyBlock2 != null)
            //{
            //    Console.WriteLine("Success!!!");
            //    Console.WriteLine(readyBlock2.Header.BlockTime);
            //}
            //else
            //{
            //    Console.WriteLine("Failed!!!");
            //}
        }
    }
}
