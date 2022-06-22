import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';
import { MatExpansionModule } from '@angular/material/expansion';
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
    MatExpansionModule,
    MatInputModule,
    MatListModule,
    MatTabsModule
  ]
})
export class MaterialModule { }
