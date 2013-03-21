using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrgPort.Data;
using OrgPort.Model;

namespace OrgPort.Data
{
    public interface INewsItemRepository
    {
        void CreateNewsItem(NewsItem newsItem);
        NewsItem GetNewsItemById(int id);
        IEnumerable<NewsItem> GetNewsItemList(int count);
        IEnumerable<NewsItem> GetNewsItemListByType(NewsItemType newsItemType, int count);
        IEnumerable<NewsItem> GetNewsItemByPerson(UserInfo person, int count);
        IEnumerable<NewsItem> GetNewsItemByDate(DateTime upToDate, TimeSpan period, int count);
    }
}
