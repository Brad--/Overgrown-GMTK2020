class Tomato : Plant {

    public Tomato() : base() {
        this.viability = 95;
        this.droughtLevel = 20;
        this.droughtResistance = 5;
        this.overwaterLevel = 95;
        this.overwaterResistance = 1;
        this.propagationChance = 5;
        this.bugResistance = 8;

        this.baseHarvestPrice = 100;
        this.storePrice = 20;

        this.ticksToGrow = 10;
        this.waterConsumptionLevel = 25;
    }
}