using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem_2___SpyGram
{
    class Program
    {
        static void Main(string[] args)
        {
            var privateKey = Console.ReadLine();
            var massegeToSend = Console.ReadLine();
            var pattern = @"(?<sender>^TO:\s[A-Z]+;)(?<massade>\sMESSAGE:\s[\x00-\x7F]+;$)";
            var regex = new Regex(pattern);
            var senderresult=new StringBuilder();
            var messageResult=new StringBuilder();
            var resultList=new List<string>();
            var resultDic=new Dictionary<string,List<string>>();

            while (massegeToSend != "END")
            {
                if (regex.IsMatch(massegeToSend))
                {
                    var allmassage = regex.Match(massegeToSend);
                    var sender = allmassage.Groups["sender"].Value;
                    var message = allmassage.Groups["massade"].Value;
                    var keyList = privateKey.ToCharArray();
                    var keyIndex = 0;
                       
                    for (int i = 0; i < sender.Length; i++)
                    {
                        var currNum = int.Parse(keyList[keyIndex].ToString());
                        senderresult.Append((char)(sender[i] + currNum));
                        keyIndex++;
                        if (keyIndex == keyList.Length)
                        {
                            keyIndex = 0;
                        }
                    }
                    for (int i = 0; i < message.Length; i++)
                    {
                        var currNum = int.Parse(keyList[keyIndex].ToString());
                        messageResult.Append((char)(message[i] + currNum));
                        keyIndex++;
                        if (keyIndex == keyList.Length)
                        {
                            keyIndex = 0;
                        }
                    }
                    if (!resultDic.ContainsKey(senderresult.ToString()))
                    {
                        resultDic[senderresult.ToString()]=new List<string>();
                    }
                    resultDic[senderresult.ToString()].Add(messageResult.ToString());
                  
                    messageResult.Clear();
                    senderresult.Clear();

                }
                massegeToSend = Console.ReadLine();
            }

           foreach (var item in resultDic.OrderBy(s => s.Key, StringComparer.Ordinal))
            {
                foreach (var mess in item.Value)
                {
                    Console.WriteLine($"{item.Key}{mess}");
                }
            }
        }
    }
}
