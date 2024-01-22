import { Component, Input, Output } from '@angular/core';
import { EventEmitter } from '@angular/core';

@Component({
  selector: 'app-quantity-button',
  standalone: true,
  imports: [],
  templateUrl: './quantity-button.component.html',
  styleUrl: './quantity-button.component.scss'
})
export class QuantityButtonComponent {
  @Input()
  value: number = 1;
  dec() {
    this.resize(-1);
  }
  inc() {
    this.resize(+1);
  }

  resize(delta: number) {
    this.value += delta;
    this.valueChange.emit(this.value);
  }
  @Output()
  valueChange = new EventEmitter<number>();

}
