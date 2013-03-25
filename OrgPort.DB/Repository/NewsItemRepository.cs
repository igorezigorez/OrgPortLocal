using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrgPort.Data;
using OrgPort.Model;


namespace OrgPort.DB.Repository
{
    public class NewsItemRepository : BaseDBRepository, INewsItemRepository
    {
        public NewsItemRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public void CreateNewsItem(NewsItem newsItem)
        {
            GetDbSet<NewsItem>().Add(newsItem);
            this.UnitOfWork.SaveAllChanges();
        }

        public NewsItem GetNewsItemById(int id)
        {
            return GetDbSet<NewsItem>().Find(id);
        }

        public IEnumerable<NewsItem> GetNewsItemList(int count, int startIndex)
        {
            return GetDbSet<NewsItem>().Skip(startIndex).Take(count);
        }

        public IEnumerable<NewsItem> GetNewsItemListByType(NewsItemType newsItemType, int count, int startIndex)
        {
            return GetDbSet<NewsItem>().Where(n => n.Type == newsItemType).Skip(startIndex).Take(count);
        }

        public IEnumerable<NewsItem> GetNewsItemByUser(User user, int count, int startIndex)
        {
            return GetDbSet<NewsItem>().Where(n => n.Users.Contains(user)).Skip(startIndex).Take(count);
        }

        public IEnumerable<NewsItem> GetNewsItemByDate(DateTime upToDate, TimeSpan period, int count, int startIndex)
        {
            throw new NotImplementedException();
        }
    }
}
