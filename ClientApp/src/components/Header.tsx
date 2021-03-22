import { Button } from '@chakra-ui/button'
import { Flex, Box, Spacer, Text } from '@chakra-ui/layout'

interface Props {
  text?: string;
  bottomPadding?: number;
  buttonColor: string,
  buttonText: string
  buttonOnClick: () => void
}

function Header({
  text = "Book Tracker",
  bottomPadding = 4,
  buttonColor,
  buttonText,
  buttonOnClick
}: Props) {
  return (
    <Flex paddingBottom={bottomPadding}>
      <Box>
        <Text fontSize="3xl">{text}</Text>
      </Box>
      <Spacer />
      <Box>
        <Button colorScheme={buttonColor} onClick={buttonOnClick}>{buttonText}</Button>
      </Box>
    </Flex>
  )
}

export default Header;
