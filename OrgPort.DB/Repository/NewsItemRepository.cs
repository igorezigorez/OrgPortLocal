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
            return GetDbSet<NewsItem>().OrderBy(n => n.Date).Skip(startIndex).Take(count);
        }

        public IEnumerable<NewsItem> GetNewsItemListByType(NewsItemType newsItemType, int count, int startIndex)
        {
            return GetDbSet<NewsItem>().Where(n => n.Type == newsItemType).OrderBy(n => n.Date).Skip(startIndex).Take(count);
        }

        public IEnumerable<NewsItem> GetNewsItemByUser(User user, int count, int startIndex)
        {
            return GetDbSet<NewsItem>().Where(n => n.Users.Contains(user)).OrderBy(n => n.Date).Skip(startIndex).Take(count);
        }

        public IEnumerable<NewsItem> GetNewsItemByDate(DateTime upToDate, TimeSpan period, int count, int startIndex)
        {
            throw new NotImplementedException();
        }

        void INewsItemRepository.CreateNewsItem(NewsItem newsItem)
        {
            throw new NotImplementedException();
        }

        NewsItem INewsItemRepository.GetNewsItemById(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<NewsItem> INewsItemRepository.GetNewsItemList(int count, int startIndex)
        {
            throw new NotImplementedException();
        }

        IEnumerable<NewsItem> INewsItemRepository.GetNewsItemListByType(NewsItemType newsItemType, int count, int startIndex)
        {
            throw new NotImplementedException();
        }

        IEnumerable<NewsItem> INewsItemRepository.GetNewsItemListByTag(Tag tag, int count, int startIndex)
        {
            throw new NotImplementedException();
        }

        IEnumerable<NewsItem> INewsItemRepository.GetNewsItemByUser(User person, int count, int startIndex)
        {
            throw new NotImplementedException();
        }

        IEnumerable<NewsItem> INewsItemRepository.GetNewsItemByDate(DateTime upToDate, TimeSpan period, int count, int startIndex)
        {
            throw new NotImplementedException();
        }
    }
}
