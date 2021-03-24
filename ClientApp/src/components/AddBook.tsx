import { Button } from '@chakra-ui/button';
import { FormControl, FormLabel } from '@chakra-ui/form-control';
import { Input } from '@chakra-ui/input';
import { Stack, Box } from '@chakra-ui/layout';
import { Select } from '@chakra-ui/select';
import { useState } from 'react';
import Book from '../models/book';
import Bookshelf from '../models/bookshelf';

interface Props {
  bookshelves?: Array<Bookshelf>;
  onAdd: (book: Book) => void;
}

function AddBook() {
  const [title, setTitle] = useState('');
  const [author, setAuthor] = useState('');
  const [isbn, setISBN] = useState('');
  const [publisher, setPublisher] = useState('');
  const [publicationDate, setPublicationDate] = useState('');
  const [bookshelf, setBookshelf] = useState('');

  return (
    <form>
      <Stack>
        <FormControl isRequired>
          <FormLabel>Title</FormLabel>
          {/* We are setting the input's value equal to the state because we want React to be single
            source of truth */}
          <Input
            placeholder="Title"
            value={title}
            onChange={event => setTitle(event.target.value)}
          />
        </FormControl>

        <FormControl>
          <FormLabel>Author</FormLabel>
          <Input
            placeholder="Author"
            value={author}
            onChange={event => setAuthor(event.target.value)}
          />
        </FormControl>

        <FormControl>
          <FormLabel>ISBN</FormLabel>
          <Input placeholder="ISBN" value={isbn} onChange={event => setISBN(event.target.value)} />
        </FormControl>

        <FormControl>
          <FormLabel>Publisher</FormLabel>
          <Input
            placeholder="Publisher"
            value={publisher}
            onChange={event => setPublisher(event.target.value)}
          />
        </FormControl>

        <FormControl>
          {/* Look at this code to add a date picker:
              (https://github.com/chakra-ui/chakra-ui/issues/580) */}
          <FormLabel>Publication Date</FormLabel>
          <Input
            placeholder="Publication Date"
            value={publicationDate}
            onChange={event => setPublicationDate(event.target.value)}
          />
        </FormControl>

        <FormControl isRequired>
          <FormLabel>Bookshelf</FormLabel>
          <Select
            placeholder="Select bookshelf"
            value={bookshelf}
            onChange={event => setBookshelf(event.target.value)}
          >
            {/* We are using the ID of the bookshelf as its value */}
            <option value="1">Foo</option>
            <option value="2">Bar</option>
          </Select>
        </FormControl>

        <Box paddingTop={2}>
          <Button colorScheme="blue">Add book</Button>
        </Box>
      </Stack>
    </form>
  );
}

export default AddBook;
