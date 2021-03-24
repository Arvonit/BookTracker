import { Table, Tbody, Td, Th, Thead, Tr } from '@chakra-ui/table';

function BookList() {
  return (
    <Table variant="simple">
      <Thead>
        <Tr>
          <Th>ID</Th>
          <Th>Title</Th>
          <Th>Author</Th>
          <Th>ISBN</Th>
          <Th>Publisher</Th>
          <Th>Publication Date</Th>
          <Th>Bookshelf</Th>
        </Tr>
      </Thead>
      <Tbody>
        <Tr>
          <Td>1</Td>
          <Td>The Adventures of Huckleberry Finn</Td>
          <Td>Mark Twain</Td>
          <Td>0123456789</Td>
          <Td>Arvind Publishing Inc.</Td>
          <Td>12/01/1890</Td>
          <Td>Want To Read</Td>
        </Tr>
        <Tr>
          <Td>2</Td>
          <Td>Bill Gates Autobiography</Td>
          <Td>Steve Jobs</Td>
          <Td>23490418</Td>
          <Td>Arvind Publishing Inc.</Td>
          <Td>12/21/2010</Td>
          <Td>Read</Td>
        </Tr>
      </Tbody>
    </Table>
  );
}

export default BookList;
