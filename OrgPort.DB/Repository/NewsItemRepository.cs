using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrgPort.Data;


namespace OrgPort.DB.Repository
{
    public class NewsItemRepository : INewsItemRepository
    {
        void INewsItemRepository.CreateNewsItem(OrgPort.Model.NewsItem newsItem)
        {
            //using (var context = new DBContext){
            //}
        }

        OrgPort.Model.NewsItem INewsItemRepository.GetNewsItemById(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<OrgPort.Model.NewsItem> INewsItemRepository.GetNewsItemList(int count)
        {
            throw new NotImplementedException();
        }

        IEnumerable<OrgPort.Model.NewsItem> INewsItemRepository.GetNewsItemListByType(OrgPort.Model.NewsItemType newsItemType, int count)
        {
            throw new NotImplementedException();
        }

        IEnumerable<OrgPort.Model.NewsItem> INewsItemRepository.GetNewsItemByPerson(OrgPort.Model.UserInfo person, int count)
        {
            throw new NotImplementedException();
        }

        IEnumerable<OrgPort.Model.NewsItem> INewsItemRepository.GetNewsItemByDate(DateTime upToDate, TimeSpan period, int count)
        {
            throw new NotImplementedException();
        }
    }
}
