class Plant {
    // Plant characteristsics
    public int viability; //95 means %95 chance per tick to survive, 5% chance to die
    public int droughtLevel; // Less waterLevel than droughtLevel = drought
    public int droughtResistance; // 5 means %5 chance to survive a drought tick
    public int overwaterLevel;
    public int overwaterResistance; // 5 means %5 chance to survive a drought tick
    public int baseHarvestPrice;
    public int storePrice;
    public int propagationChance; // 5 means %5 chance to propagate a seedling per tick
    public int bugResistance;
    public int ticksToGrow;
    public int waterConsumptionLevel;

    // Active plant stats (Future: fertilizerActive, etc)
    public int waterLevel; // 0 - 100
    private PlotGrowthState growthState;
    public int ticksSpentGrowing;

    public Plant() {
        this.waterLevel = 20;
    }

    public Seed() {
        this.ticksSpentGrowing = 0;
        this.growthState = PlotGrowthState.Seedling;
    }

    public Tick() {
        if (SurvivesThisTick()) {
            Grow();
        } else {
            Die();
        }
    }

    private Grow() {
        this.ticksSpentGrowing++;
        this.waterLevel -= this.waterConsumptionLevel;
        if (this.ticksSpentGrowing >= this.ticksToGrow) {
            this.growthState = PlotGrowthState.Grown;
        } else if (this.ticksSpentGrowing <= this.ticksToGrow / 2) {
            this.growthState = PlotGrowthState.Growing;
        }
    }

    private Die() {
        this.growthState = PlotGrowthState.Dead;
    }

    private bool SurvivesThisTick() {
        if (this.growthState == PlotGrowthState.Dead) {
            return false;
        }
        if (!SurvivesViabilityRoll()) {
            LogDeath("viability");
            return false;
        }
        if (!SurvivesDroughtRoll()) {
            LogDeath("drought");
            return false;
        }
        if (!SurvivesOverwaterRoll()) {
            LogDeath("overwatering");
            return false;
        }
        if (!SurvivesBugRoll()) {
            LogDeath("bugs (as in software because 'insects' aren't impl yet)");
            return false;
        }
        return true;
    }

    private void LogDeath(string cause) {
        Debug.Log("Cause of death: " + cause);
    }

    private bool SurvivesViabilityRoll() {
        return Roll(this.viability);
    }

    private bool SurvivesDroughtRoll() {
        if (this.waterLevel >= this.droughtLevel) {
            return true;
        }
        return Roll(this.droughtResistance);
    }

    private bool SurvivesOverwaterRoll() {
        if (this.waterLevel < this.overwaterLevel) {
            return true;
        }
        return Roll(this.overwaterResistance);
    }

    private bool SurvivesBugRoll() {
        return true;
    }

    private bool Roll(int survivalRate) {
        // If the next random number 0-100 is greater than survival rate, you die
        return random.Next(0, 100) > survivalRate;
    }

    public OnMouseClick() {
        // Check which tool is active
        // Is it being harvested or watered?
    }
}