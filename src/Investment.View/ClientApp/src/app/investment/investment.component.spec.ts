import { ComponentFixture, TestBed } from '@angular/core/testing';
import { ReactiveFormsModule } from '@angular/forms';
import { InvestmentComponent } from './investment.component';
import { InvestmentService } from '../services/investment.service';
import { of } from 'rxjs';

class MockInvestmentService {
    getInvestments() {
      return of([]);
    }
  }

describe('InvestmentComponent', () => {
  let component: InvestmentComponent;
  let fixture: ComponentFixture<InvestmentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InvestmentComponent ],
      imports: [ ReactiveFormsModule ],
      providers: [
        { provide: InvestmentService, useClass: MockInvestmentService }
      ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(InvestmentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});