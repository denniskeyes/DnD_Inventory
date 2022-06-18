import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent {
  //character: string = 'Character Name';
  charList = [
    'faenking',
    'heinen',
    'kaladin',
    'magdar',
    'torinn',
    'yaris'
  ];
}
