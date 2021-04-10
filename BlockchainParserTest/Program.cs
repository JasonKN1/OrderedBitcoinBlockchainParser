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
            //OrderedBlockchainParser_Class orderedBlockchainParser1 = new OrderedBlockchainParser_Class(@"F:\data\blocks", @"F:\blockProcessContextFile", null);
            //ParserBlock readyBlock1 = orderedBlockchainParser1.getNextBlock();
            //if (readyBlock1 != null)
            //{
            //    Console.WriteLine("Success!!!");
            //    Console.WriteLine(readyBlock1.Header.BlockTime);
            //}
            //else {
            //    Console.WriteLine("Failed!!!");
            //}

            ////II.增量启动
            //OrderedBlockchainParser_Class orderedBlockchainParser2 = new OrderedBlockchainParser_Class(@"F:\data\blocks", @"F:\blockProcessContextFile", "BPC_418031_2016年06月26日07时57分38秒.dat.rar");
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
