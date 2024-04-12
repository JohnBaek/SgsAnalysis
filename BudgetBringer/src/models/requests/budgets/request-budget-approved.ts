import {EnumApprovalStatus} from "../../enums/enum-approval-status";

/**
 * 예산정보 승인 정보 요청 클래스
 */
export class RequestBudgetApproved {
  /**
   * 500K 이상 예산 여부
   */
  isAbove500K: boolean;

  /**
   * 기안일 ( 날짜가아닌 일반 스트링데이터도 포함 될 수 있다. )
   */
  approvalDate: string;

  /**
   * 설명
   */
  description: string | null;

  /**
   * 섹터 아이디
   */
  sectorId: string;

  /**
   * DbModelBusinessUnit 아이디
   */
  businessUnitId: string;

  /**
   * DbModelCostCenter 아이디
   */
  costCenterId: string;

  /**
   * DbModelCountryBusinessManager 아이디
   */
  countryBusinessManagerId: string;

  /**
   * 인보이스 번호
   */
  poNumber: number;

  /**
   * 승인 상태 : PO 전/후 , Invoice 발행 여부
   */
  approvalStatus: EnumApprovalStatus;

  /**
   * 승인된 예산
   */
  approvalAmount: number;

  /**
   * Actual
   */
  actual: number;

  /**
   * OcProjectName
   */
  ocProjectName: string | null;

  /**
   * BossLineDescription
   */
  bossLineDescription: string | null;
}