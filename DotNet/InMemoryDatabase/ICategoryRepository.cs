using Dul.Data;

namespace InMemoryDatabase
{
    /// <summary>
    /// 리포지토리 인터페이스 => BREAD SHOP 패턴 사용
    /// </summary>
    public interface ICategoryRepository : IBreadShop<Category>
    {
        // Empty
    }
}
