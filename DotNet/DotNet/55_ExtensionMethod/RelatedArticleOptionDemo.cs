using System;

/// <summary>
/// 관련글 옵션: 이전글, 현재글, 다음글
/// </summary>
public enum RelatedArticleOption
{
    /// <summary>
    /// 이전글
    /// </summary>
    Prev = 1,

    /// <summary>
    /// 현재글
    /// </summary>
    Current = 0,

    /// <summary>
    /// 다음글
    /// </summary>
    Next = -1
}

/// <summary>
/// RelatedArticleOption 열거형을 문자열로 표시해주는 확장
/// </summary>
public static class RelatedArticleOptionExtensions
{
    /// <summary>
    /// 열거형을 문자열로 표시
    /// </summary>
    public static string ToFriendlyString(this RelatedArticleOption rao)
    {
        string r = "";

        switch (rao)
        {
            case RelatedArticleOption.Prev:
                r = "이전글";
                break;
            case RelatedArticleOption.Current:
                r = "현재글";
                break;
            case RelatedArticleOption.Next:
                r = "다음글";
                break;
            default:
                r = "현재글";
                break;
        }

        return r; 
    }
}

class RelatedArticleOptionDemo
{
    static void Main()
    {
        // 정수형으로 비교
        int related = 1;
        if (related == (int)RelatedArticleOption.Prev)
        {
            Console.WriteLine("이전글입니다.");
        }
        else if (related == (int)RelatedArticleOption.Current)
        {
            Console.WriteLine("현재글입니다.");
        }
        else
        {
            Console.WriteLine("다음글입니다.");
        }

        // 열거형 자체로 비교
        RelatedArticleOption relatedArticle = RelatedArticleOption.Next;
        switch (relatedArticle)
        {
            case RelatedArticleOption.Prev:
                Console.WriteLine("이전글입니다.");
                break;
            case RelatedArticleOption.Current:
                Console.WriteLine("현재글입니다.");
                break;
            case RelatedArticleOption.Next:
                Console.WriteLine("다음글입니다.");
                break;
            default:
                Console.WriteLine("현재글입니다.");
                break;
        }

        // 확장 메서드 사용
        Console.WriteLine(RelatedArticleOption.Prev.ToFriendlyString()); // 이전글
        Console.WriteLine(RelatedArticleOption.Current.ToFriendlyString()); // 현재글
        Console.WriteLine(RelatedArticleOption.Next.ToFriendlyString()); // 다음글
    }
}
