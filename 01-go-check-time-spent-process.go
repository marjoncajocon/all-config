start := time.Now()

/// here your code here 

elapsed := time.Since(start) // Calculate difference
fmt.Printf("Process took %f seconds\n", elapsed.Seconds())
