using Moq;
using OrgPort.Data;
using OrgPort.Domain.Handlers;
using OrgPort.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OrgPort.ServicesModel.Test
{
    public class GettingNewsByType
    {
        private readonly Mock<INewsItemRepository> _newsItemRepository;
        private const int _defaultStartIndex = 0;
        private const int _defaultCount = 2;
        private const NewsItemType _defaultNewsItemType = NewsItemType.NewsItem;

        public GettingNewsByType()
        {
            _newsItemRepository = new Mock<INewsItemRepository>();
        }

        [Fact]
        public void NewsItemAdded_UpdateRepository()
        {
            _newsItemRepository
                .Setup(r => r.GetNewsItemListByType(_defaultNewsItemType, _defaultCount, _defaultStartIndex))
                .Returns(new NewsItem[] { new NewsItem(), new NewsItem() })
                .Verifiable();

            var handler = new GetNewsItemListByCategory(_newsItemRepository.Object);

            var result = handler.Execute(_defaultNewsItemType, _defaultCount, _defaultStartIndex);

            _newsItemRepository.Verify();

            Assert.NotNull(result);
            Assert.Equal(result.Count(), 2);
        }
    }
}
