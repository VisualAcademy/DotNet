using Dul.Data;
using System.Collections.Generic;
using System.Linq;

namespace InMemoryDatabase
{
    public class CategoryRepositoryInMemory : ICategoryRepository
    {
        //[!] 인메모리 데이터베이스 역할을 하는 정적 컬렉션 개체 생성
        private static List<Category> _categories = new List<Category>();

        public CategoryRepositoryInMemory()
        {
            // 생성자에서 컬렉션 이니셜라이저를 사용하여 3개의 데이터로 초기화
            _categories = new List<Category>()
            {
                new Category() { CategoryId = 1, CategoryName = "책" },
                new Category() { CategoryId = 2, CategoryName = "강의" },
                new Category() { CategoryId = 3, CategoryName = "컴퓨터" }
            };
        }

        /// <summary>
        /// 입력: 데이터베이스에 데이터를 저장
        /// </summary>
        public Category Add(Category model)
        {
            // 가장 큰 CategoryId에 1 더한 값으로 새로운 CategoryId 생성
            // 실제 데이터베이스에서는 자동 증가값(시퀀스)을 사용
            model.CategoryId = _categories.Max(c => c.CategoryId) + 1; 
            _categories.Add(model);
            return model;
        }

        /// <summary>
        /// 상세: 단일 데이터 출력
        /// </summary>
        public Category Browse(int id)
        {
            return _categories.Where(c => c.CategoryId == id).SingleOrDefault();
        }

        /// <summary>
        /// 삭제: 특정 키값(Id)에 해당하는 데이터 지우기 
        /// </summary>
        public bool Delete(int id)
        {
            int r = _categories.RemoveAll(c => c.CategoryId == id);
            if (r > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 수정: 지정한 모델로 데이터 수정하기 
        /// </summary>
        public bool Edit(Category model)
        {
            // Select() 메서드에서 값을 수정하고 다시 반환하는 형태로 특정 속성의 값 변경
            var result = _categories
                .Where(c => c.CategoryId == model.CategoryId)
                .Select(c => { c.CategoryName = model.CategoryName; return c; })
                .FirstOrDefault(); // SingleOrDefault()도 가능
            if (result != null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 개수, 건수
        /// </summary>
        public int Has()
        {
            return _categories.Count;
        }

        /// <summary>
        /// 정렬: OrderOption 열거형의 데이터에 따른 정렬 조건 처리 
        /// </summary>
        /// <param name="orderOption">OrderOption 열거형</param>
        /// <returns>읽기전용(IEnumerable)으로 정렬된 레코드셋</returns>
        public IEnumerable<Category> Ordering(OrderOption orderOption)
        {
            IEnumerable<Category> categories;

            switch (orderOption)
            {
                case OrderOption.Ascending:
                    //[a] 확장 메서드 사용
                    categories = _categories.OrderBy(c => c.CategoryName);
                    break;
                case OrderOption.Descending:
                    //[b] 쿼리 식 사용
                    categories = (from category in _categories
                                  orderby category.CategoryName descending
                                  select category);
                    break;
                default:
                    //[c] 기본 값
                    categories = _categories;
                    break;
            }

            return categories;
        }

        /// <summary>
        /// 페이징: PageSize만큼 나눠서 필요한 페이지의 데이터 조회
        /// </summary>
        /// <param name="pageNumber">페이지 번호: 1, 2, 3, ...</param>
        /// <param name="pageSize">페이지 크기: 한 페이지 당 10개씩 표시</param>
        /// <returns>읽고 쓰기가 가능한(List) 페이징 처리된 레코드셋</returns>
        public List<Category> Paging(int pageNumber = 1, int pageSize = 10)
        {
            return
                _categories
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();
        }

        /// <summary>
        /// 출력: 전체 데이터 출력, GetAll() 메서드
        /// </summary>
        public List<Category> Read()
        {
            return _categories;
        }

        /// <summary>
        /// 검색: 지정한 매개 변수에 해당하는 데이터만 조회
        /// </summary>
        public List<Category> Search(string query)
        {
            return _categories
                .Where(category => category.CategoryName.Contains(query)).ToList();
        }
    }
}
