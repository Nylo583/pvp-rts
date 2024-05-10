using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{



    public virtual void OnTurnBegin() {
        //cycle through buffs/debuffs and downtick 1
    }

    public virtual void OnTurnEnd() { }

    public virtual void OnBasicAttackSelect() { }
    public virtual void OnBasicAttackFire() { }
    public virtual void OnSkillSelect() { }
    public virtual void OnSkillFire() { }
    public virtual void OnUltimateSelect() { }
    public virtual void OnUltimateFire() { }
    public virtual void OnTakeDamage(float amt) { }
    public virtual void OnStagger() { 
        //remove self from action order
    }
    public virtual void OnDealDamage(float amt) { }
    public virtual void OnKillEnemy() { }
    public virtual void OnDeath() {
        Destroy(this.gameObject);
    }
}
