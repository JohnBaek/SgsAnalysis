import {CommonGridModel} from "../../../../shared/grids/common-grid-model";
import {RequestQuery} from "../../../../models/requests/query/request-query";
import {CommonColumnDefinitions} from "../../../../shared/grids/common-grid-column-definitions";

/**
 * P&L Owner Grid Model
 */
export class BudgetProcessGridPLOwner extends CommonGridModel {
  /**
   * Date
   */
  public date: string;
  /**
   * Year of Date
   */
  public year : number;
  /**
   * Constructor
   * @param date
   * @param year
   * @param requestQuery
   */
  constructor( date: string , year : number , requestQuery: RequestQuery ) {
    super();
    this.date = date;
    this.year = year;
    this.requestQuery = requestQuery;
    this.columDefined = [
      CommonColumnDefinitions.createColumnDefinitionForTextFilter(250 , "countryBusinessManagerName", date , null,false, false) ,
      CommonColumnDefinitions.createColumnDefinitionForTextFilter(250 , "budgetYear", `${year.toString()}FY BudgetYear`, this.numberValueFormatter,false) ,
      CommonColumnDefinitions.createColumnDefinitionForTextFilter(250 , "approvedYear", `${year.toString()}FY Approved Amount`, this.numberValueFormatter,false) ,
      CommonColumnDefinitions.createColumnDefinitionForTextFilter(250 , "remainingYear", `${year.toString()}FY Remaining Amount`, this.numberValueFormatter,false) ,
      CommonColumnDefinitions.createColumnDefinitionForNumberFilter(250 , "ratio", `${year.toString()}FY Ratio(%)`, null ,false, function(params) {
        return params.value.toFixed(3);
      }) ,
    ];
    this.setSkeleton();
    this.setChart('bar', 'countryBusinessManagerName');
  }
}


