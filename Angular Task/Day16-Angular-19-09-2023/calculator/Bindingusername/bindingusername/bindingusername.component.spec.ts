import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BindingusernameComponent } from './bindingusername.component';

describe('BindingusernameComponent', () => {
  let component: BindingusernameComponent;
  let fixture: ComponentFixture<BindingusernameComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BindingusernameComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(BindingusernameComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
