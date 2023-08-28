import { Component } from '@angular/core';

@Component({
  selector: 'app-mortgage-calculator',
  templateUrl: './mortgage-calculator.component.html',
  styleUrls: ['./mortgage-calculator.component.css']
})
export class MortgageCalculatorComponent {
  purchasePrice: number = 0;
  downPayment: number = 0;
  repaymentTime: number = 0;
  interestRate: number = 0;
  loanAmount: number | null = null;
  monthlyPayment: number | null = null;

  calculateLoan(): void {
    if (this.purchasePrice >= this.downPayment) {
      this.loanAmount = this.purchasePrice - this.downPayment;
      const monthlyInterestRate = this.interestRate / 100 / 12;
      const numberOfPayments = this.repaymentTime * 12;
      this.monthlyPayment = (this.loanAmount * monthlyInterestRate) / (1 - Math.pow(1 + monthlyInterestRate, -numberOfPayments));
    } else {
      this.loanAmount = null;
      this.monthlyPayment = null;
    }
  }
}
