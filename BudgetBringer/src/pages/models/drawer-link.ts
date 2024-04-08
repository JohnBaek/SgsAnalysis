/**
 * 라우팅 정보
 */
export class DrawerLink {
  /**
   * 생성자
   * @param title 타이틀
   * @param description 설명
   * @param route 라우팅 패스
   * @param icon 아이콘 정보
   * @param permissions 상세 권한 정보
   */

  constructor(title: string,description: string,  route: string, icon: string, permissions:Array<string>) {
    this.title = title;
    this.description = description;
    this.route = route;
    this.icon = icon;
    this.permissions = permissions;
  }

  /**
   * 필요권한
   */
  public permissions: Array<string> = [];

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

  /**
   * 설명
   */
  public description: string = "";
}
