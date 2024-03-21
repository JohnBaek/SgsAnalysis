/**
 * 라우팅 정보
 */
export class RoutingInformation {
  /**
   * 생성자
   * @param title 타이틀
   * @param route 라우팅 패스
   * @param icon 아이콘 정보
   */
  constructor(title: string, route: string, icon: string) {
    this.title = title;
    this.route = route;
    this.icon = icon;
  }

  /**
   * 타이틀
   */
  public title: string = "";

  /**
   * 라우팅 패스
   */
  public route: string = "";

  /**
   * 아이콘 정보
   */
  public icon: string = "";
}