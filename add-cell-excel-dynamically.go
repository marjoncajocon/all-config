func addCell(index int) string {
	label := ""

	for index >= 0 {
		remainder := index % 26
		label = string('A'+rune(remainder)) + label
		index = (index / 26) - 1
	}

	return label
}
