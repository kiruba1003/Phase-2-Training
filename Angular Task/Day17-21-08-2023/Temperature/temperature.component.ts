import { Component } from '@angular/core';

@Component({
  selector: 'app-temperature',
  templateUrl: './temperature.component.html',
  styleUrls: ['./temperature.component.css']
})
export class TemperatureConverterComponent {
  temperature: number = 0;
  selectedUnit: string = 'celsius';
  convertedTemperature: number | null = null;
  convertedUnit: string = '';

  convertTemperature(): void {
    if (this.selectedUnit === 'celsius') {
      this.convertedTemperature = (this.temperature * 9/5) + 32;
      this.convertedUnit = 'Fahrenheit';
    } else if (this.selectedUnit === 'fahrenheit') {
      this.convertedTemperature = (this.temperature - 32) * 5/9;
      this.convertedUnit = 'Celsius';
    }
  }
}
