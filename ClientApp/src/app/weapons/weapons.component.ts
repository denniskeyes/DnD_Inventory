import { Component, Input, OnInit } from '@angular/core';
import { DataHandlerService } from '../services/data-handler.service';

@Component({
  selector: 'app-weapons',
  templateUrl: './weapons.component.html',
  styleUrls: ['./weapons.component.scss']
})
export class WeaponsComponent implements OnInit {

  constructor(private dataHandlerService: DataHandlerService) { }

  @Input() character: string;
  weaponsList: any;

  ngOnInit(): void {
    this.populateWeaponsList(this.character);
  }

  populateWeaponsList(char:string) {
    this.dataHandlerService.getWeapons(char).subscribe((response:any) => {
      this.weaponsList = response;
    });
  }

}
