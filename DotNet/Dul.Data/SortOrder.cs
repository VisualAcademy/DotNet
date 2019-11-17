using System;

namespace Dul.Data
{
    /// <summary>
    /// SortOrder 열거형: 행의 데이터 정렬 방법을 지정합니다. 
    /// </summary>
    [Obsolete("OrderOption 열거형을 사용하세요.")]
    public enum SortOrder
    {
        /// <summary>
        /// 오름차순
        /// </summary>
        Ascending,

        /// <summary>
        /// 내림차순
        /// </summary>
        Descending,

        /// <summary>
        /// 기본값
        /// </summary>
        None
    }
}
