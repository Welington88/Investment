import { Component, EventEmitter, Input, OnInit } from '@angular/core';
import { FormGroup, FormControl, FormBuilder, Validators } from '@angular/forms';
import { IInvestment } from '../models/investment.interface';
import { InvestmentService } from '../services/investment.service';

@Component({
  selector: 'app-investment',
  templateUrl: './investment.component.html',
  styleUrls: ['./investment.component.css']
})

export class InvestmentComponent implements OnInit {
  @Input() onSubmit = new EventEmitter<IInvestment>();
  @Input() btnText!: string;
  investments : IInvestment[] = [];
  investment : IInvestment = <IInvestment>{};

  formLabel : string = "";
  isEditMode : boolean = false;
  form! : FormGroup;

  constructor(private investmentService : InvestmentService,
              private fb : FormBuilder) {
            this.fb.group({
              'initialValue' : ["", Validators.required],
              'periodInMonths' : ["", Validators.required]
            });
        this.formLabel = "Simulador de Investimento";
    }

  ngOnInit(): void {
    this.form = new FormGroup({
      initialValue: new FormControl('', [Validators.required]),
      periodInMonths: new FormControl('', [Validators.required]),
    });
  }
  
  get initialValue(){
    return this.form.get("initialValue")!;
  }

  get periodInMonths (){
    return this.form.get("periodInMonths")!;
  }

  private setValueInvestment(investment: any) {
      this.investments.push(investment);
      this.investments.forEach(i => {
        i.initialValue = parseFloat(investment.finalValue.toFixed(2));
        i.netValue = parseFloat(i.netValue.toFixed(2));
      });   
  }

  submit() {
    if (this.form.invalid) {
      return;
    }

      this.investment.initialValue = this.form.controls['initialValue'].value;
      this.investment.periodInMonths = this.form.controls['periodInMonths'].value;
      
      this.investmentService.getValueInvestment(this.investment)
      .subscribe(resp =>{
            this.setValueInvestment(resp);
            this.form.get("initialValue")?.setValue('0');
            this.form.get("periodInMonths")?.setValue('0');
        },
        error => {
          alert(error.error);
        }
      );
      this.cancel();
      
      this.form.dirty;
  }

  async send(event : any) {
  };

  cancel() : void{
      this.formLabel = "Nova Análise";
      this.isEditMode = false;
      this.investment = <IInvestment>{};
      this.form.get("initialValue")?.setValue(' ');
      this.form.get("periodInMonths")?.setValue(' ');
      this.form.dirty;
  };
}