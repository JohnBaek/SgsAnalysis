import {CommonGridModel} from "../../../../shared/grids/common-grid-model";
import {RequestQuery} from "../../../../models/requests/query/request-query";
import CommonGridSkeletonRenderer from "../../../../shared/grids/common-grid-skeleton-renderer.vue";

/**
 * 진생상황 P&L Owner 그리드 모델
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
      {
        field: "countryBusinessManagerName",
        headerName: date,
        headerClass: 'ag-grids-custom-header',
      },
      {
        headerName:`${year.toString()}FY` ,
        headerClass: 'ag-grids-custom-header',
        children: [
          {
            headerName:'Budget Amount ' ,
            field: "budgetAmount",
            headerClass: 'ag-grids-custom-header',
            valueFormatter: this.numberValueFormatter,
          }
        ]
      },
      {
        // headerName:`${year.toString()}&${(year-1).toString()} FY` ,
        headerName:`${year.toString()}FY` ,
        headerClass: 'ag-grids-custom-header',
        children: [
          {
            field: "budgetApprovedYearSum",
            headerClass: 'ag-grids-custom-header',
            headerName:' Approved Amount',
            valueFormatter: this.numberValueFormatter,
          }
        ]
      },
      {
        headerName:`${year.toString()}FY` ,
        headerClass: 'ag-grids-custom-header',
        children: [
          {
            field: "budgetRemainingYear",
            headerClass: 'ag-grids-custom-header',
            headerName:'Remaining Amount ' ,
            valueFormatter: this.numberValueFormatter,
          }
        ]
      },
    ];
    this.columDefinedSkeleton = JSON.parse(JSON.stringify(this.columDefined));
    this.columDefinedSkeleton.forEach(item => {
      item.cellRenderer = CommonGridSkeletonRenderer;
      item.children?.forEach(child => {
        child.cellRenderer = CommonGridSkeletonRenderer;
      })
    });
    this.chartDefined = [
      {   type: 'bar'
        , xKey: 'countryBusinessManagerName'
        , yKey: 'budgetAmount'
        , yName: 'Budget Amount '
        , tooltip: {
          renderer: function ({ datum, xKey, yKey }) {
            return {
              content: Intl.NumberFormat('en-US', { style: 'decimal', maximumFractionDigits: 0 }).format(datum[yKey]) ,
              title: datum[xKey]
            };
          },
        },
      },
      {   type: 'bar'
        , xKey: 'countryBusinessManagerName'
        , yKey: 'budgetApprovedYearSum'
        , yName: 'Approved Amount '
        , tooltip: {
          renderer: function ({ datum, xKey, yKey }) {
            return {
              content: Intl.NumberFormat('en-US', { style: 'decimal', maximumFractionDigits: 0 }).format(datum[yKey]) ,
              title: datum[xKey]
            };
          },
        },
      },
      {   type: 'bar'
        , xKey: 'countryBusinessManagerName'
        , yKey: 'budgetRemainingYear'
        , yName: 'Remaining Amount '
        , tooltip: {
          renderer: function ({ datum, xKey, yKey }) {
            return {
              content: Intl.NumberFormat('en-US', { style: 'decimal', maximumFractionDigits: 0 }).format(datum[yKey]) ,
              title: datum[xKey]
            };
          },
        },
      },
    ]
  }
}


