import {map, Observable} from "rxjs";
import {ajax} from "rxjs/internal/ajax/ajax";

/**
 * http 클라이언트 요청 서비스
 */
export class HttpService {
  /**
   * GET 요청을 수행하는 메서드.
   * @param url 요청할 리소스의 URL
   * @param params 요청에 포함할 파라미터 오브젝트
   * @returns Observable로 요청 응답을 반환한다.
   */
  static requestGet<T>(url: string, params?: Record<string, any>): Observable<T> {
    const searchParams = new URLSearchParams();

    // params 객체를 반복하여 모든 키-값 쌍을 처리합니다.
    if (params) {
      for (const [key, value] of Object.entries(params)) {
        if (Array.isArray(value)) {
          // 값이 배열인 경우, 배열의 각 요소를 별도로 추가합니다.
          value.forEach(item => searchParams.append(key, item));
        } else {
          // 배열이 아닌 경우, 단일 값으로 추가합니다.
          searchParams.append(key, value);
        }
      }
    }

    const queryString = searchParams.toString() ? `?${searchParams}` : '';

    const fullUrl = `${url}${queryString}`;
    return ajax.getJSON<T>(fullUrl);
  }

  /**
   * POST 요청을 수행하는 메서드.
   * @param url 요청할 리소스의 URL
   * @param body 요청에 포함할 본문 데이터
   * @param headers 요청에 포함할 추가 헤더 (선택사항)
   * @returns Observable로 요청 응답을 반환한다.
   */
  static requestPost<T>(url: string, body: any, headers?: Record<string, string>): Observable<T> {
    return ajax.post(url, body, { 'Content-Type': 'application/json', ...headers })
    .pipe(
      map(response => response.response as T)
    );
  }

  /**
   * PUT 요청을 수행하는 메서드.
   * @param url 요청할 리소스의 URL
   * @param body 요청에 포함할 본문 데이터
   * @param headers 요청에 포함할 추가 헤더 (선택사항)
   * @returns Observable로 요청 응답을 반환한다.
   */
  static requestPut<T>(url: string, body: any, headers?: Record<string, string>): Observable<T> {
    return ajax.put(url, body, { ...headers, 'Content-Type': 'application/json' })
    .pipe(
      map(response => response.response as T)
    );
  }

  /**
   * DELETE 요청을 수행하는 메서드.
   * @param url 요청할 리소스의 URL
   * @param headers 요청에 포함할 추가 헤더 (선택사항)
   * @returns Observable로 요청 응답을 반환한다.
   */
  static requestDelete<T>(url: string, headers?: Record<string, string>): Observable<T> {
    return ajax.delete(url, headers)
    .pipe(
      map(response => response.response as T)
    );
  }
}