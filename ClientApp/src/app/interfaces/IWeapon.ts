export interface IWeapon {
  name: string;
  attack: IAttack;
  damage1: IDamage;
  damage2: IDamage;
  savingThrow?: string;
  savingThrowDc?: string;
  saveEffect?: string;
  description?: string;
}

interface IAttack {
  type?: string;
  modifier?: number;
  proficient?: boolean;
  range?: string;
  magicBonus?: number;
  critRange?: number;
}

interface IDamage {
  dmgRoll?: string;
  dmgModType?: string;
  dmgExtra?: number;
  type?: string;
  critVal?: number;
}
