import { Button } from '@chakra-ui/button';
import { FormControl, FormLabel } from '@chakra-ui/form-control';
import { Input } from '@chakra-ui/input';
import { Stack, Box } from '@chakra-ui/layout';
import { Select } from '@chakra-ui/select';
import Book from '../models/book';
import Bookshelf from '../models/bookshelf';

interface Props {
  bookshelves: Array<Bookshelf>;
  onAdd: (book: Book) => void;
}

function AddBook() {
  return (
    <form>
      <Stack>
        <FormControl isRequired>
          <FormLabel>Title</FormLabel>
          <Input placeholder="Title" />
        </FormControl>

        <FormControl>
          <FormLabel>Author</FormLabel>
          <Input placeholder="Author" />
        </FormControl>

        <FormControl>
          <FormLabel>ISBN</FormLabel>
          <Input placeholder="ISBN" />
        </FormControl>

        <FormControl>
          <FormLabel>Publisher</FormLabel>
          <Input placeholder="Publisher" />
        </FormControl>

        <FormControl>
          {/* Look at this code to add a date picker:
              (https://github.com/chakra-ui/chakra-ui/issues/580) */}
          <FormLabel>Publication Date</FormLabel>
          <Input placeholder="Publication Date" />
        </FormControl>

        <FormControl isRequired>
          <FormLabel>Bookshelf</FormLabel>
          <Select placeholder="Select bookshelf">
            <option>Foo</option>
            <option>Bar</option>
          </Select>
        </FormControl>

        <Box paddingTop={2}>
          <Button colorScheme="blue">Add book</Button>
        </Box>
      </Stack>
    </form>
  )
}

export default AddBook;