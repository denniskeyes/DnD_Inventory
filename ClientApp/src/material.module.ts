import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';
import { MatListModule } from '@angular/material/list';
import { MatInputModule } from '@angular/material/input';
import { MatTabsModule } from '@angular/material/tabs';

@NgModule({
  declarations: [],
  //imports: [
  //  CommonModule
  //]
  exports: [
    MatButtonModule,
    MatInputModule,
    MatListModule,
    MatTabsModule
  ]
})
export class MaterialModule { }
