using System.Reflection;
using Newtonsoft.Json;

namespace Features.Extensions;

/// <summary>
/// Object 확장
/// </summary>
public static class ObjectExtension
{
    /// <summary>
    /// T 데이터를 T로 클로닝 한다.
    /// </summary>
    /// <param name="source">원본 데이터</param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T? FromClone<T>(this T? source) where T : class
    {
        // 원본데이터가 유효하지 않을경우 
        if (source == null) 
            return null;
        
        // 질렬화 한다.
        string serialized = JsonConvert.SerializeObject(source);
        
        // 역직렬화 해서 반환한다.
        return JsonConvert.DeserializeObject<T>(serialized);
    }
    
    /// <summary>
    /// 대상소스로부터 데이터를 카피해서 T 형으로 반환한다.
    /// </summary>
    /// <param name="source"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T? FromCopyValue<T>(this object? source) where T : class
    {
        if (source == null) 
            return null;

        T? destination = Activator.CreateInstance<T>();

        // 소스 데이터로부터 프로퍼티를 가져온다.
        PropertyInfo[] sourceProperties = source.GetType().GetProperties();

        // 목적지 데이터로부터 프로퍼티를 가져온다.
        PropertyInfo[] destinationProperties = destination.GetType().GetProperties();
    
        // 모든 소스데이터에 대해 처리한다.
        foreach (PropertyInfo sourceProperty in sourceProperties)
        {
            // 모든 목적지 데이터에 대해 처리한다.
            foreach (PropertyInfo destinationProperty in destinationProperties)
            {
                // 프로퍼티 이름과 타입이 일치하는 경우에만 값을 복사한다.
                if (sourceProperty.Name == destinationProperty.Name && sourceProperty.PropertyType == destinationProperty.PropertyType)
                {
                    // 데이터를 업데이트한다. destination 객체에 sourceProperty의 값을 설정한다.
                    destinationProperty.SetValue(destination, sourceProperty.GetValue(source));
                    
                    // 일치하는 프로퍼티를 찾았으니 더 이상의 검색을 중지한다.
                    break; 
                }
            }
        }
        
        // 수정된 destination을 반환한다.
        return destination; 
    }

    
}