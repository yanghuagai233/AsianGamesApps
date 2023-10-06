using HtmlAgilityPack;
using System.Collections.ObjectModel;
using System.Text;

namespace AsianGameRank
{
    public class RankInfo
    {
        int _Rank;
        string _CountryName;
        int _Gold;
        int _Silver;
        int _Copper;
        int _Total;
        int _RankByTotal;
        string _CountryCode;
        bool _LoadState;

        public RankInfo(int rank,string countryname,int gold,int silver,int copper,int total,int rankByTotal,string countrycode)
        {
            _Rank = rank;
            _CountryName=countryname.Replace("\n", "").Replace(" ", "").Replace("\t", "").Replace("\r", ""); 
            _Gold = gold;
            _Silver=silver;
            _Copper=copper;
            _Total=total;
            _RankByTotal=rankByTotal;
            _CountryCode=countrycode.Replace("\n", "").Replace(" ", "").Replace("\t", "").Replace("\r", ""); 
            _LoadState=true;
        }
        public RankInfo(bool S)
        {

            if (S) throw new NotImplementedException();
            else _LoadState = S;
        }



        public int Rank { get { return _Rank; }  }
        public string CountryName { get { return _CountryName; } }
        public int Gold { get { return _Gold; } }
        public int Silver { get { return _Silver; } }
        public int Copper { get { return _Copper; } }
        public int Total { get { return _Total; }  }
        public int RankByTotal { get { return _RankByTotal; }  }
        public string CountryCode { get { return _CountryCode; }  }
        public bool LoadState { get { return _LoadState; } }
        

        public override string ToString()
        {
            StringBuilder sb=new StringBuilder();
            if (!_LoadState)
                return "错误，未连接到网络";
            string ta = "\t";
            if (_Rank < 10)
            {
                sb.Append("排名：" + _Rank + "   ");//3space
            }
            else
            {
                sb.Append("排名：" + _Rank + "  ");//2
            }
            sb.Append("参赛队伍："+_CountryName+'\n');

            sb.Append("金牌数：" + _Gold + ta);
            sb.Append("银牌数：" + _Silver + ta);
            sb.Append("铜牌数：" + _Copper + '\n');
            sb.Append("总奖牌排名：" + _RankByTotal);
            /*if (_CountryName.Length <= 2)
            {
                sb.Append(ta);
            }
            sb.Append("金牌数："+_Gold+ta);
            sb.Append("银牌数："+_Silver+ta);
            sb.Append("铜牌数：" + _Copper+ta);
            sb.Append("总奖牌排名："+_RankByTotal);
            */
            return sb.ToString();
        }
    }
    // All the code in this file is included in all platforms.
    public class GetRank
    {
        public static async Task<ObservableCollection<RankInfo>> GetRankInfo()
        {
            ObservableCollection<string> tags = new ObservableCollection<string>();
            ObservableCollection<RankInfo> rankInfos = new ObservableCollection<RankInfo>();
            try
            {
                var client = new HttpClient();

                // 亚运会奖牌数据的URL
                var uri = new Uri("https://info.hangzhou2022.cn/zh/results/all-sports/medal-standings.htm");

                var response = await client.GetAsync(uri);

                var content = await response.Content.ReadAsStringAsync();

                // 创建HtmlDocument对象
                var htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(content);

                // 使用XPath或CSS选择器来查找和提取你需要的数据
                // 提取所有的<tr>标签
                var tdTags = htmlDocument.DocumentNode.SelectNodes("//td");
                int i = 0;
                // 然后，你可以遍历tdTags集合来获取每个<td>标签的内容
                
                foreach (var tdTag in tdTags)
                {
                    i++;
                    string encodedString = tdTag.InnerText;
                    string decodedString = System.Net.WebUtility.HtmlDecode(encodedString);
                    tags.Add(decodedString);
                    if (tags.Count == 8)
                    {
                        RankInfo rankInfo = new RankInfo(
                            int.Parse(tags[0]),
                            tags[1],
                            int.Parse(tags[2]),
                            int.Parse(tags[3]),
                            int.Parse(tags[4]),
                            int.Parse(tags[5]),
                            int.Parse(tags[6]),
                            tags[7]
                            );
                        rankInfos.Add(rankInfo);
                        tags = new ObservableCollection<string>();
                    }
                    if (i == 335) { break; }

                }
                return rankInfos;
            }
            catch (Exception)
            {
                for (int i = 0; i < 36; i++)
                {
                    rankInfos.Add(new RankInfo(false));
                }
                return rankInfos;
                
            }

        }
    }
}