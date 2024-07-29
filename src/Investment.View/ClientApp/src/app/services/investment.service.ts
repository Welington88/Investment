import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';
import { Observable, of, Subject } from 'rxjs';
import { IInvestment } from '../models/investment.interface';


@Injectable({
  providedIn: 'root'
})
export class InvestmentService {

  constructor(private http: HttpClient) { }

  getValueInvestment(investment: IInvestment){
    return this.http.patch("https://localhost:7009/api/Investment", investment);
  }
}
