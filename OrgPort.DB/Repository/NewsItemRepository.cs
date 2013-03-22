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

        public IEnumerable<NewsItem> GetNewsItemList(int count)
        {
            return GetDbSet<NewsItem>().Take(count);
        }

        public IEnumerable<NewsItem> GetNewsItemListByType(NewsItemType newsItemType, int count)
        {
            return GetDbSet<NewsItem>().Where(n => n.Type == newsItemType).Take(count);
        }

        public IEnumerable<NewsItem> GetNewsItemByUser(User user, int count)
        {
            return GetDbSet<NewsItem>().Where(n => n.Users.Contains(user)).Take(count);
        }

        public IEnumerable<NewsItem> GetNewsItemByDate(DateTime upToDate, TimeSpan period, int count)
        {
            throw new NotImplementedException();
        }
    }
}
