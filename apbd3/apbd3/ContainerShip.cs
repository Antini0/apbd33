using apbd3.Containers;

namespace apbd3;

public class ContainerShip
{
    public List<container> listOfContainers = new List<container>();
    public double maxSpeed { get; set; }
    public double maxCombinedMass { get; set; }
    public int containerLimit { get; set; }
    public double currentMass = 0;
    public bool massOk = true;

    public ContainerShip(double maxSpeed, double maxCombinedMass, int containerLimit)
    {
        this.maxSpeed = maxSpeed;
        this.maxCombinedMass = maxCombinedMass;
        this.containerLimit = containerLimit;
    }

    public void addContainer(container c)
    {
        checkMass(c.cargoMass);
        if (massOk)
        {
            listOfContainers.Add(c);
            currentMass += c.cargoMass + c.ownMass;
        }
    }
    
    public void addMultipleContainers(List<container> list)
    {
        double mass = 0;
        
        foreach (var c in list)
        {
            mass += c.cargoMass + c.ownMass;
        }
        
        checkMass(mass);

        if (massOk)
        {
            foreach (var c in list)
            {
                listOfContainers.Add(c);
                currentMass += c.cargoMass + c.ownMass;
            } 
        }
    }
    public void removeContainer(container c)
    {
        if (listOfContainers.Contains(c))
        {
            listOfContainers.Remove(c);
            currentMass -= c.cargoMass + c.ownMass;
        }
    }
    
    public void unloadShip()
    {
        listOfContainers.Clear();
        currentMass = 0;
    }
    
    public void swapContainers(container c1, string serialNum)
    {
        List<int> indexesToRemove = new List<int>();

        for (int i = 0; i < listOfContainers.Count; i++)
        {
            if (listOfContainers[i].serialNum == serialNum)
            {
                indexesToRemove.Add(i);
            }
        }

        foreach (int index in indexesToRemove)
        {
            currentMass -= listOfContainers[index].cargoMass + listOfContainers[index].ownMass;
            listOfContainers.RemoveAt(index);
        }

        if (indexesToRemove.Count > 0)
        {
            int lastIndex = indexesToRemove[indexesToRemove.Count - 1];
            checkMass(c1.cargoMass);
            if (massOk)
            {
                listOfContainers.Insert(lastIndex, c1);
                currentMass += c1.cargoMass + c1.ownMass;
            }
        }
    }

    public void checkMass(double addedMass)
    {
        if (currentMass + addedMass > maxCombinedMass)
        {
            massOk = false;
            throw new OverfillExcetion("maksymalna masa ładunku przekroczona");
        }
        
    }
    
    public override string ToString()
    {
        string containerInfo = "";
        foreach (container container in listOfContainers)
        {
            containerInfo += container.ToString() + "\n";
        }

        return $"Container Ship:\nMax Speed: {maxSpeed}\nMax Combined Mass: {maxCombinedMass}\nContainer Limit: {containerLimit}\nContainers:\n{containerInfo}Current Mass: {currentMass}";
    }
}